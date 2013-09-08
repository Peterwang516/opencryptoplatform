using System;
using System.Collections.Generic;
using System.Text;
using Arbiter;
using CommonFinancial;

namespace ForexPlatform
{
    /// <summary>
    /// Message allows to obtain the operating parameters of the source.
    /// </summary>
    [Serializable]
    public class GetExecutionSourceParametersResponceMessage : ResponceMessage
    {
        bool _supportActiveOrderManagement;
        public bool SupportActiveOrderManagement
        {
          get { return _supportActiveOrderManagement; }
          set { _supportActiveOrderManagement = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public GetExecutionSourceParametersResponceMessage(bool supportsActiveOrderManagement)
            : base(true)
        {
            _supportActiveOrderManagement = supportsActiveOrderManagement;
        }
    }
}
