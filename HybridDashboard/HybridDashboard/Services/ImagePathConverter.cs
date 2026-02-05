using System.Globalization;

namespace HybridDashboard
{
    public class ImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (value is null) return null;

                var path = value.ToString() ?? string.Empty;

                if (path.Contains("_content/"))
                {
                    var idx = path.LastIndexOf('/');
                    if (idx >= 0 && idx < path.Length - 1)
                        path = path.Substring(idx + 1);
                }

                if (path.StartsWith("/")) path = path.Substring(1);

                if (!string.IsNullOrWhiteSpace(path))
                    return ImageSource.FromFile(path);

                return null;
            }
            catch
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotSupportedException();
    }
}
