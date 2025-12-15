using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace shoes.Services
{
    public static class ImageService
    {
        private static readonly string ProductImagesFolder = "Resources";

        /// <summary>
        /// PKGH: Получение полного пути к папке с изображениями товаров
        /// </summary>
        public static string GetImagesFolderPath()
        {
            string folderPath = Path.Combine(Application.StartupPath, ProductImagesFolder);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            return folderPath;
        }

        /// <summary>
        /// PKGH: Загрузка изображения товара
        /// </summary>
        public static Image LoadProductImage(string imageFileName)
        {
            try
            {
                if (string.IsNullOrEmpty(imageFileName))
                    return Properties.Resources.picture;

                string imagePath = Path.Combine(GetImagesFolderPath(), imageFileName);

                if (File.Exists(imagePath))
                {
                    return Image.FromFile(imagePath);
                }
                else
                {
                    return Properties.Resources.picture;
                }
            }
            catch
            {
                return Properties.Resources.picture;
            }
        }

        /// <summary>
        /// PKGH: Сохранение изображения товара
        /// </summary>
        public static string SaveProductImage(string tempImagePath, string oldImageFileName = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(oldImageFileName))
                {
                    DeleteProductImage(oldImageFileName);
                }

                string extension = Path.GetExtension(tempImagePath);
                string newFileName = $"{Guid.NewGuid():N}{extension}";
                string newImagePath = Path.Combine(GetImagesFolderPath(), newFileName);

                File.Copy(tempImagePath, newImagePath, true);

                return newFileName;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при сохранении изображения: {ex.Message}");
            }
        }

        /// <summary>
        /// PKGH: Удаление изображения товара
        /// </summary>
        public static bool DeleteProductImage(string imageFileName)
        {
            try
            {
                if (string.IsNullOrEmpty(imageFileName))
                    return true;

                string imagePath = Path.Combine(GetImagesFolderPath(), imageFileName);

                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                    return true;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// PKGH: Открытие диалога выбора изображения
        /// </summary>
        public static string OpenImageDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Изображения (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|Все файлы (*.*)|*.*";
                openFileDialog.Title = "Выберите изображение товара";
                openFileDialog.Multiselect = false;
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }

            return null;
        }
    }
}