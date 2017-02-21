using System.Collections.Generic;

namespace GoogleHash2017.Model
{
    public abstract class BaseEntity
    {
        #region Instance Properties

        public string this[string index]
        {
            get { return MetaFields[index]; }
            set { MetaFields[index] = value; }
        }

        public IDictionary<string, string> MetaFields
        {
            get
            {
                return _metaFields;
            }
        }

        #endregion

        #region Constructors

        protected BaseEntity()
        {
            _metaFields = new Dictionary<string, string>();
        }

        #endregion

        #region Instance Fields

        private IDictionary<string, string> _metaFields;

        #endregion
    }
}

