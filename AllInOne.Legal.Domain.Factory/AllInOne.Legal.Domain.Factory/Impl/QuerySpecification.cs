using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using log4net;

using NHibernate;
using NHibernate.Criterion;

namespace AllInOne.Legal.Domain.Factory.Impl
{
    public interface IQuerySpectification
    {
        /// <summary>
        /// Append with Equal ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <returns>QuerySpecification</returns>
        QuerySpecification Equal<V>(string propertyName, V value);
        
        /// <summary>
        /// Append with Equal ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <returns>QuerySpecification</returns>
        QuerySpecification EqualForOR<V, V1>(string propertyName, V value, string secondPropertyName, V1 secondValue);
        
        /// <summary>
        /// Append with Greater Than ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <returns>QuerySpecification</returns>
        QuerySpecification GreaterThan<V>(string propertyName, V value);

        /// <summary>
        /// Append with LessThan ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <returns>QuerySpecification</returns>
        QuerySpecification LessThan<V>(string propertyName, V value);

        /// <summary>
        /// Append the with Between ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the first value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the first field.</param>
        /// <param name="startValue">The value of the first field.</param>
        /// <param name="endValue">The value of the first field.</param>
        /// <returns>QuerySpecification</returns>
        QuerySpecification Between<V>(string propertyName, V startValue, V endValue);

        /// <summary>
        /// Append the with In ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the first value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the first field.</param>
        /// <param name="value">The value of the first field.</param>
        /// <returns>QuerySpecification</returns>
        QuerySpecification In<V>(string propertyName, List<V> value);

        /// <summary>
        /// Append the with Not In ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the first value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the first field.</param>
        /// <param name="value">The value of the first field.</param>
        /// <returns>QuerySpecification</returns>
        QuerySpecification NotIn<V>(string propertyName, List<V> value);

        /// <summary>
        /// Append the with Like ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the first value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the first field.</param>
        /// <param name="value">The value of the first field.</param>
        /// <returns>QuerySpecification</returns>
        QuerySpecification Like<V>(string propertyName, V value);

        /// <summary>
        /// Append with IsEmpty ICriterion.
        /// </summary>
        /// <param name="detachedCriteria">Existing detached criteria object.</param>
        /// <param name="propertyName">Name of the property of the desginated object.</param>
        /// <returns>QuerySpecification</returns>
        QuerySpecification IsEmpty(string propertyName);
        
        /// <summary>
        /// Append with IsEmpty for OR ICriterion
        /// </summary>
        /// <param name="propertyName">The name of the field.</param>
        /// <param name="secondPropertyName">The name of the second field.</param>
        /// <returns>QuerySpecification</returns>
        QuerySpecification IsEmptyForOR(string propertyName, string secondPropertyName);

        /// <summary>
        /// Append with IsNotEmpty ICriterion.
        /// </summary>
        /// <param name="detachedCriteria">Existing detached criteria object.</param>
        /// <param name="propertyName">Name of the property of the desginated object.</param>
        /// <returns>QuerySpecification</returns>
        QuerySpecification IsNotEmpty(string propertyName);
        
        /// <summary>
        /// Append with IsNotEmpty for OR ICriterion
        /// </summary>
        /// <param name="propertyName">The name of the field.</param>
        /// <param name="secondPropertyName">The name of the second field.</param>
        /// <returns>QuerySpecification</returns>
        QuerySpecification IsNotEmptyForOR(string propertyName, string secondPropertyName);

        /// <summary>
        /// Append with IsNull ICriterion.
        /// </summary>
        /// <param name="detachedCriteria">Existing detached criteria object.</param>
        /// <param name="propertyName">Name of the property of the desginated object.</param>
        /// <returns>QuerySpecification</returns>
        QuerySpecification IsNull(string propertyName);

        /// <summary>
        /// Append with IsNotNull ICriterion.
        /// </summary>
        /// <param name="detachedCriteria">Existing detached criteria object.</param>
        /// <param name="propertyName">Name of the property of the desginated object.</param>
        /// <returns>QuerySpecification</returns>
        QuerySpecification IsNotNull(string propertyName);

        /// <summary>
        /// Clear the existing query list.
        /// </summary>
        /// <returns>QuerySpecification</returns>
        QuerySpecification New();
    }

    public class QuerySpecification : IQuerySpectification
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(QuerySpecification));
        ICollection<ICriterion> queryList = null;

        public QuerySpecification()
        {
            queryList = new List<ICriterion>();
        }

        /// <summary>
        /// Append with Equal ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification Equal<V>(string propertyName, V value)
        {
            Logger.Debug("equal:  property name - " + propertyName + ". value - " + value);
            try
            {
                queryList.Add(Expression.Eq(propertyName, value));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Append with Equal ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification EqualForOR<V, V1>(string propertyName, V value, string secondPropertyName, V1 secondValue)
        {
            Logger.Debug("OrEqual:  property name - " + propertyName + ". value - " + value);
            try
            {
                queryList.Add(Expression.Or(Expression.Eq(propertyName, value), Expression.Eq(secondPropertyName, secondValue)));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Append with Not Equal ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification NotEqual<V>(string propertyName, V value)
        {
            Logger.Debug("equal:  property name - " + propertyName + ". value - " + value);
            try
            {
                queryList.Add(Expression.Not(Expression.Eq(propertyName, value)));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Append with Greater Than ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification GreaterThan<V>(string propertyName, V value)
        {
            Logger.Debug("greater: property name - " + propertyName + ". value - " + value);
            try
            {
                queryList.Add(Expression.Gt(propertyName, value));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Append with LessThan ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification LessThan<V>(string propertyName, V value)
        {
            Logger.Debug("LessThan: property name - " + propertyName + ". value - " + value);
            try
            {
                queryList.Add(Expression.Lt(propertyName, value));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Append the with Between ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the first value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the first field.</param>
        /// <param name="startValue">The value of the first field.</param>
        /// <param name="endValue">The value of the first field.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification Between<V>(string propertyName, V startValue, V endValue)
        {
            Logger.Debug("between:  property name - " + propertyName + ". start - " + startValue + " => end -" + endValue);
            try
            {
                queryList.Add(Expression.Between(propertyName, startValue, endValue));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Append the with In ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the first value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the first field.</param>
        /// <param name="value">The value of the first field.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification In<V>(string propertyName, List<V> value)
        {
            //Logger.Info("In: value - " + value.CombinedListOfStringToSingle<V>(v => v, ","));

            try
            {
                queryList.Add(Expression.In(propertyName, value));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Append the with Not In ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the first value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the first field.</param>
        /// <param name="value">The value of the first field.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification NotIn<V>(string propertyName, List<V> value)
        {
            //Logger.Info("NotIn: value - " + value.CombinedListOfStringToSingle<V>(v => v, ","));

            try
            {
                queryList.Add(Expression.Not(Expression.In(propertyName, value)));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Append the with Like ICriterion
        /// </summary>
        /// <typeparam name="V">Type of the first value.</typeparam>
        /// <param name="detachedCriteria">DetachedCriteria which has constructed with other criteria.</param>
        /// <param name="propertyName">The name of the first field.</param>
        /// <param name="value">The value of the first field.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification Like<V>(string propertyName, V value)
        {
            Logger.Info("Like: value - " + value);

            try
            {
                queryList.Add(Expression.Like(propertyName, value.ToString(), MatchMode.Anywhere));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Append with IsEmpty ICriterion.
        /// </summary>
        /// <param name="detachedCriteria">Existing detached criteria object.</param>
        /// <param name="propertyName">Name of the property of the desginated object.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification IsEmpty(string propertyName)
        {
            Logger.Debug("between:  property name - " + propertyName);
            try
            {
                queryList.Add(Restrictions.IsEmpty(propertyName));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Append with IsEmpty for OR ICriterion
        /// </summary>
        /// <param name="propertyName">The name of the field.</param>
        /// <param name="secondPropertyName">The name of the second field.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification IsEmptyForOR(string propertyName, string secondPropertyName)
        {
            Logger.Debug("IsEmptyForOR:  property name - " + propertyName + ". Second Property Name - " + secondPropertyName);
            try
            {
                queryList.Add(Expression.Or(Expression.IsEmpty(propertyName), Expression.IsEmpty(secondPropertyName)));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Append with IsNotEmpty ICriterion.
        /// </summary>
        /// <param name="detachedCriteria">Existing detached criteria object.</param>
        /// <param name="propertyName">Name of the property of the desginated object.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification IsNotEmpty(string propertyName)
        {
            Logger.Debug("between:  property name - " + propertyName);
            try
            {
                queryList.Add(Restrictions.IsNotEmpty(propertyName));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Append with IsNotEmpty for OR ICriterion
        /// </summary>
        /// <param name="propertyName">The name of the field.</param>
        /// <param name="secondPropertyName">The name of the second field.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification IsNotEmptyForOR(string propertyName, string secondPropertyName)
        {
            Logger.Debug("IsNotEmptyForOR:  property name - " + propertyName + ". Second Property Name - " + secondPropertyName);
            try
            {
                queryList.Add(Expression.Or(Expression.IsNotEmpty(propertyName), Expression.IsNotEmpty(secondPropertyName)));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Append with IsNull ICriterion.
        /// </summary>
        /// <param name="detachedCriteria">Existing detached criteria object.</param>
        /// <param name="propertyName">Name of the property of the desginated object.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification IsNull(string propertyName)
        {
            Logger.Debug("between:  property name - " + propertyName);
            try
            {
                queryList.Add(Restrictions.IsNull(propertyName));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Append with IsNotNull ICriterion.
        /// </summary>
        /// <param name="detachedCriteria">Existing detached criteria object.</param>
        /// <param name="propertyName">Name of the property of the desginated object.</param>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification IsNotNull(string propertyName)
        {
            Logger.Debug("between:  property name - " + propertyName);
            try
            {
                queryList.Add(Restrictions.IsNotNull(propertyName));
                return this;
            }
            catch (Exception e)
            {
                Logger.Error("Constructing the query criteria have some error.", e);
                throw;
            }
        }

        /// <summary>
        /// Clear the existing query list.
        /// </summary>
        /// <returns>QuerySpecification</returns>
        public QuerySpecification New()
        {
            this.queryList.Clear();
            return this;
        }

        /// <summary>
        /// To get the list of query
        /// </summary>
        public ICollection<ICriterion> Query
        {
            get
            {
                if (this.queryList == null)
                    return null;

                return this.queryList;
            }
        }

    }
}
