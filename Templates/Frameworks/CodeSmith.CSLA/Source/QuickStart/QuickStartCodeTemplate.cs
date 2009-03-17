﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

using CodeSmith.Engine;
using CodeSmith.SchemaHelper;

using SchemaExplorer;

using Configuration=CodeSmith.SchemaHelper.Configuration;

namespace QuickStart
{
    public class QuickStartCodeTemplate : CSLABaseTemplate
    {
        #region Private Member(s)

        private DatabaseSchema _database;

        #endregion

        #region Constructor(s)

        public QuickStartCodeTemplate()
        {
            DataAccessImplementation = DataAccessMethod.ParameterizedSQL;
        }

        #endregion

        #region 1. DataSource

        [Category("1. DataSource")]
        [Description("Source Database")]
        public DatabaseSchema SourceDatabase
        {
            get
            {
                return _database;
            }
            set
            {
                if (value != null)
                {
                    _database = value;
                    OnDatabaseChanged();
                }
            }
        }

        [Browsable(false)]
        public List<Entity> Entities { get; set; }

        #endregion

        #region 2. Solution

        [Category("2. Solution")]
        [Description("Launch Visual Studio after generation.")]
        [DefaultValue(true)]
        public bool LaunchVisualStudio { get; set; }

        [Category("2. Solution")]
        [Description("The language the project will be built in.")]
        [DefaultValue("")]
        public LanguageEnum Language { get; set; }

        [Editor(typeof(System.Windows.Forms.Design.FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [Optional, NotChecked]
        [Category("2. Solution")]
        [Description("The path to the Solution location.")]
        [DefaultValue("")]
        public string Location { get; set; }

        [Category("2. Solution")]
        [Description("Name of the project to be generated.")]
        [DefaultValue("")]
        public string SolutionName { get; set; }

        #endregion

        #region 3. Business Project

        [Category("3. Business Project")]
        [Description("The namespace for the business project.")]
        public string BusinessProjectName { get; set; }

        [Category("3. Business Project")]
        [Description("Uses private member backing variables for properties.")]
        [DefaultValue(false)]
        public bool UseMemberVariables { get; set; }

        #endregion

        #region 4. Data Project

        [Category("4. Data Project")]
        [Description("Changes how the Business Data Access Methods and Data Access Layer are implemented.")]
        public DataAccessMethod DataAccessImplementation { get; set; }

        [Category("4. Data Project")]
        [Description("The Name Space for the Data Project.")]
        public string DataProjectName { get; set; }

        [Category("4. Data Project")]
        [Description("The name of the Data Access class.")]
        [DefaultValue("DataAccessLayer")]
        public string DataClassName { get; set; }

        [Category("4. Data Project")]
        [Description("The value all sql parameters should be prefixed with.")]
        [DefaultValue("@p_")]
        public string ParameterPrefix
        {
            get
            {
                return Configuration.Instance.ParameterPrefix;
            }
            set
            {
                Configuration.Instance.ParameterPrefix = value;
            }
        }

        [Category("4. Data Project")]
        [Description("Changes how the business layer and data acces layer is implemented.")]
        [DefaultValue(false)]
        public bool UseLazyLoading { get; set; }

        #endregion

        #region 5. Interface Project

        [Category("5. Interface Project")]
        [Description("The namespace for the interface project.")]
        public string InterfaceProjectName { get; set; }

        #endregion

        #region Public Methods

        public virtual void Generate()
        {
        }

        #endregion

        #region Private Method(s)

        public static void LaunchVisualStudioWithSolution(string solutionLink)
        {
            const string args = "/build debug";
            using (Process.Start(solutionLink, args))
            { }
        }

        private void OnDatabaseChanged()
        {
            Entities = new EntityManager(SourceDatabase).Entities;

            if (string.IsNullOrEmpty(DataClassName))
                DataClassName = "DataAccessLayer";

            if (string.IsNullOrEmpty(SolutionName))
                SolutionName = SourceDatabase.Namespace();

            if (string.IsNullOrEmpty(BusinessProjectName))
                BusinessProjectName = string.Format("{0}.Business", SourceDatabase.Namespace());

            if (string.IsNullOrEmpty(DataProjectName))
                DataProjectName = string.Format("{0}.Data", SourceDatabase.Namespace());

            if (string.IsNullOrEmpty(InterfaceProjectName))
                InterfaceProjectName = string.Format("{0}.UI", SourceDatabase.Namespace());

            //if (string.IsNullOrEmpty(TestProjectName))
            //    TestProjectName = string.Format("{0}.Test", SourceDatabase.Namespace());

            if (string.IsNullOrEmpty(Location))
                Location = Path.Combine(
                    CodeSmith.Engine.Configuration.Instance.CodeSmithTemplatesDirectory,
                    Path.Combine("CSLA", SourceDatabase.Name));
        }

        #endregion
    }
}