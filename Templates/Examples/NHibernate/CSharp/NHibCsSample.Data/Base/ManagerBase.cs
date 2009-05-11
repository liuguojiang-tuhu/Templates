using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Criterion;

namespace NHibCsSample.Generated.Base
{
    public interface IManagerBase<T, TKey>
    {
        // Get Methods
        T GetById(TKey Id);
        IList<T> GetAll();
        IList<T> GetAll(int maxResults);
        IList<T> GetByCriteria(params ICriterion[] criterionList);
        IList<T> GetByCriteria(int maxResults, params ICriterion[] criterionList);
        T GetUniqueByCriteria(params ICriterion[] criterionList);
        IList<T> GetByExample(T exampleObject, params string[] excludePropertyList);
        IList<T> GetByQuery(string query);
        IList<T> GetByQuery(int maxResults, string query);
        T GetUniqueByQuery(string query);
        
        // CRUD Methods
        object Save(T entity);
        void SaveOrUpdate(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Refresh(T entity);
        void Evict(T entity);

        // Properties
        System.Type Type { get; }
        INHibernateSession Session { get; }
    }

    public abstract partial class ManagerBase<T, TKey> : IManagerBase<T, TKey>
    {
        #region Declarations

        protected INHibernateSession session;
        protected const int defaultMaxResults = 100;

        #endregion

        #region Constructors

        public ManagerBase()
        {
            session = NHibernateSessionManager.Instance.Session;
        }
        public ManagerBase(INHibernateSession session)
        {
            this.session = session;
        }

        #endregion

        #region Get Methods

        public virtual T GetById(TKey id)
        {
            return (T)Session.GetISession().Get(typeof(T), id);
        }
        
        public IList<T> GetAll()
        {
            return GetByCriteria(defaultMaxResults);
        }
        public IList<T> GetAll(int maxResults)
        {
            return GetByCriteria(maxResults);
        }
        
        public IList<T> GetByCriteria(params ICriterion[] criterionList)
        {
            return GetByCriteria(defaultMaxResults, criterionList);
        }
        public IList<T> GetByCriteria(int maxResults, params ICriterion[] criterionList)
        {
            ICriteria criteria = Session.GetISession().CreateCriteria(typeof(T)).SetMaxResults(maxResults);

            foreach (ICriterion criterion in criterionList)
                criteria.Add(criterion);

            return criteria.List<T>();
        }
        public T GetUniqueByCriteria(params ICriterion[] criterionList)
        {
            ICriteria criteria = Session.GetISession().CreateCriteria(typeof(T));

            foreach (ICriterion criterion in criterionList)
                criteria.Add(criterion);

            return criteria.UniqueResult<T>();
        }
        
        public IList<T> GetByExample(T exampleObject, params string[] excludePropertyList)
        {
            ICriteria criteria = Session.GetISession().CreateCriteria(typeof(T));
            Example example = Example.Create(exampleObject);

            foreach (string excludeProperty in excludePropertyList)
                example.ExcludeProperty(excludeProperty);

            criteria.Add(example);

            return criteria.List<T>();
        }
        
        public IList<T> GetByQuery(string query)
        {
            return GetByQuery(defaultMaxResults, query);
        }
        public IList<T> GetByQuery(int maxResults, string query)
        {
            IQuery iQuery = Session.GetISession().CreateQuery(query).SetMaxResults(maxResults);
            return iQuery.List<T>();
        }
        public T GetUniqueByQuery(string query)
        {
            IQuery iQuery = Session.GetISession().CreateQuery(query);
            return iQuery.UniqueResult<T>();
        }
        
        #endregion

        #region CRUD Methods

        public object Save(T entity)
        {
            return Session.GetISession().Save(entity);
        }
        public void SaveOrUpdate(T entity)
        {
            Session.GetISession().SaveOrUpdate(entity);
        }
        public void Delete(T entity)
        {
            Session.GetISession().Delete(entity);
        }
        public void Update(T entity)
        {
            Session.GetISession().Update(entity);
        }
        public void Refresh(T entity)
        {
            Session.GetISession().Refresh(entity);
        }
        public void Evict(T entity)
        {
            Session.GetISession().Evict(entity);
        }
        
        #endregion

        #region Properties

        /// <summary>
        /// The NHibernate Session object is exposed only to the Manager class.
        /// It is recommended that you...
        /// ...use the the NHibernateSession methods to control Transactions (unless you specifically want nested transactions).
        /// ...do not directly expose the Flush method (to prevent open transactions from locking your DB).
        /// </summary>
        public System.Type Type
        {
            get { return typeof(T); }
        }
        public INHibernateSession Session
        {
            get { return session; }
        }

        #endregion
    }
}