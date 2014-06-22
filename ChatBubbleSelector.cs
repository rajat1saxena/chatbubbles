using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace WP_nosilverlight_App
{
    public class ChatBubbleSelector : DataTemplateSelector
    {
        public DataTemplate toBubble { get; set; }
        public DataTemplate fromBubble { get; set; }

        protected override DataTemplate SelectTemplateCore(object item,DependencyObject container)
        {
            var message = item as Message;
            if (message.tofrom == true)
            {
                return toBubble;
            }
            else
            {
                return fromBubble;
            }
        }
    }
}
