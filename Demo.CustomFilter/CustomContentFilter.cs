using System;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Demo.CustomFilter
{
    public class CustomContentFilter : MessageFilter
    {
        private readonly string _filterData;

        public CustomContentFilter(string filterData)
        {
            _filterData = filterData;
        }

        public override bool Match(Message message)
        {
            // the message is in soap header
            // in the <xxx> => parameter name in the IContract !!!
            var returnValue = false;

            var search = $"{"<xxx>"}{this._filterData}{"</xxx>"}";

            var s = message.ToString();
            if (!string.IsNullOrWhiteSpace(s) && s.IndexOf(search, StringComparison.Ordinal) > -1)
            {
                returnValue = true;
            }

            return returnValue;
        }

        #region unused

        public override bool Match(MessageBuffer buffer)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
