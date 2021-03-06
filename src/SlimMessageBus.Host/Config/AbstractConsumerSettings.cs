using System;

namespace SlimMessageBus.Host.Config
{
    public abstract class AbstractConsumerSettings : HasProviderExtensions, IConsumerEvents
    {
        /// <summary>
        /// The topic or queue name.
        /// </summary>
        public string Topic { get; set; }
        /// <summary>
        /// Number of concurrent competing consumer instances to be created for the bus.
        /// This dictates how many concurrent messages can be processed at a time.
        /// </summary>
        public int Instances { get; set; }

        #region Implementation of IConsumerEvents

        /// <summary>
        /// Called whenever a consumer receives an expired message.
        /// </summary>
        public Action<AbstractConsumerSettings, object> OnMessageExpired { get; set; }
        /// <summary>
        /// Called whenever a consumer errors out while processing the message.
        /// </summary>
        public Action<AbstractConsumerSettings, object, Exception> OnMessageFault { get; set; }

        #endregion

        protected AbstractConsumerSettings()
        {
            Instances = 1;
        }
    }
}