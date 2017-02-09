﻿using Newtonsoft.Json;

namespace SendGrid.Helpers.Mail
{
    /// <summary>
    /// 	Settings to determine how you would like to track the metrics of how your recipients interact with your email.
    /// </summary>
    public class TrackingSettings
    {
        /// <summary>
        /// Allows you to track whether a recipient clicked a link in your email.
        /// </summary>
        [JsonProperty(PropertyName = "click_tracking")]
        public ClickTracking ClickTracking { get; set; }

        /// <summary>
        /// Allows you to track whether the email was opened or not, but including a single pixel image in the body of the content. When the pixel is loaded, we can log that the email was opened.
        /// </summary>
        [JsonProperty(PropertyName = "open_tracking")]
        public OpenTracking OpenTracking { get; set; }

        /// <summary>
        /// Allows you to insert a subscription management link at the bottom of the text and html bodies of your email. If you would like to specify the location of the link within your email, you may use the substitution_tag.
        /// </summary>
        [JsonProperty(PropertyName = "subscription_tracking")]
        public SubscriptionTracking SubscriptionTracking { get; set; }

        /// <summary>
        /// Allows you to enable tracking provided by Google Analytics.
        /// </summary>
        [JsonProperty(PropertyName = "ganalytics")]
        public Ganalytics Ganalytics { get; set; }
    }
}