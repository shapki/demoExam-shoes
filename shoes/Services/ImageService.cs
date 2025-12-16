using System.Collections.Generic;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace shoes.Services
{
    public static class ImageService
    {
        private static readonly string ResourcesFolder = "Resources";

        /// <summary>
        /// PKGH: Получение полного пути к папке Resources
        /// </summary>
        public static string GetResourcesFolderPath()
        {
            string folderPath = Path.Combine(Application.StartupPath, ResourcesFolder);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            return folderPath;
        }

        /// <summary>
        /// PKGH: Открытие окна выбора изображения
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

        /// <summary>
        /// PKGH: Загрузка изображения товара из папки Resources
        /// </summary>
        public static Image LoadProductImage(string imageFileName)
        {
            try
            {
                if (string.IsNullOrEmpty(imageFileName))
                    return Properties.Resources.picture;

                string imagePath = Path.Combine(GetResourcesFolderPath(), imageFileName);

                if (File.Exists(imagePath))
                {
                    using (var tempImage = Image.FromFile(imagePath))
                    {
                        return new Bitmap(tempImage);
                    }
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
        /// PKGH: Сохранение изображения товара в папку Resources
        /// </summary>
        public static string SaveProductImage(string tempImagePath, string oldImageFileName = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(oldImageFileName))
                {
                    DeleteProductImage(oldImageFileName);
                }

                if (!File.Exists(tempImagePath))
                {
                    throw new FileNotFoundException($"Исходный файл не найден: {tempImagePath}");
                }

                string extension = Path.GetExtension(tempImagePath).ToLower();
                string newFileName = $"{Guid.NewGuid():N}{extension}";
                string newImagePath = Path.Combine(GetResourcesFolderPath(), newFileName);

                File.Copy(tempImagePath, newImagePath, true);

                return newFileName;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при сохранении изображения: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// PKGH: Удаление изображения товара из папки Resources
        /// </summary>
        public static bool DeleteProductImage(string imageFileName)
        {
            try
            {
                if (string.IsNullOrEmpty(imageFileName))
                    return true;

                string imagePath = Path.Combine(GetResourcesFolderPath(), imageFileName);

                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                    return true;
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении изображения {imageFileName}: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// PKGH: Проверка допустимых форматов изображений
        /// </summary>
        public static bool IsValidImageFormat(string filePath)
        {
            var validExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            string extension = Path.GetExtension(filePath).ToLower();
            return validExtensions.Contains(extension);
        }

        /// <summary>
        /// PKGH: Получение списка всех изображений в папке Resources
        /// </summary>
        public static List<string> GetAllProductImages()
        {
            try
            {
                string resourcesPath = GetResourcesFolderPath();
                if (Directory.Exists(resourcesPath))
                {
                    var imageExtensions = new[] { "*.jpg", "*.jpeg", "*.png", "*.gif", "*.bmp" };
                    var imageFiles = new List<string>();

                    foreach (var extension in imageExtensions)
                    {
                        imageFiles.AddRange(Directory.GetFiles(resourcesPath, extension));
                    }

                    return imageFiles.Select(Path.GetFileName).ToList();
                }
                return new List<string>();
            }
            catch
            {
                return new List<string>();
            }
        }
    }
}