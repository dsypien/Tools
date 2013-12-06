using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Silhouette
{
    public class Silhouette
    {
        public void Create(string filename, string fileExtension, Color selectedColor)
        {
            if (!filename.EndsWith(".png") || filename.EndsWith(fileExtension))
            {
                return;
            }
            
            using (Bitmap img = Image.FromFile(filename) as Bitmap)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        Color pixelColor = img.GetPixel(x, y);

                        img.SetPixel(x, y, Color.FromArgb(
                            pixelColor.A,
                            selectedColor
                        ));
                    }
                }

                string fileName = filename.Substring(0, filename.Length - 4) + fileExtension;

                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                img.Save(fileName);
            }
        }
    }
}
