using System;
using System.Reflection;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Ejercicio03
{
    [Preserve(AllMembers = true)]
    [ContentProperty(nameof(Source))]

    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;
            var imagenSource = ImageSource.FromResource(Source,
                typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            return imagenSource;
        }
    }
}
