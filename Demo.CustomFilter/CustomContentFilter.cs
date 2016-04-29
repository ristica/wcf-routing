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
            return true;
        }

        #region unused

        public override bool Match(MessageBuffer buffer)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
