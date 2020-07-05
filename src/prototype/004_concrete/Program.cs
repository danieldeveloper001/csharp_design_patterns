using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Program
    {
        static MediaType PromptForMediaType(IEnumerable<MediaType> supportedMediaTypes)
        {
            bool isValidMediaType;
            MediaType mediaType;
            do
            {
                Console.Write(MediaTypePromptMessage());

                isValidMediaType = Enum.TryParse<MediaType>(
                    Console.ReadLine(),
                    true,
                    out mediaType);
            } while(!isValidMediaType);

            return mediaType;

            string MediaTypePromptMessage()
            {
                var messageBuilder = new StringBuilder();
                messageBuilder.Append("Please, choose a supported media type [");
                foreach(var supportedMediaType in supportedMediaTypes)
                    messageBuilder.Append($"{supportedMediaType}, ");

                messageBuilder.Remove(messageBuilder.Length - 2, 2);
                messageBuilder.Append("] ");

                return messageBuilder.ToString();
            }
        }

        static string PromptForContent(Media media)
        {
            string content;

            do
            {
                Console.Write($"Please, input content [Max. Capacity: {media.Capacity} {media.CapacityUnit}] ");
                content = Console.ReadLine();
            } while(content.Length > media.Capacity);

            return content;
        }

        static void Main(string[] args)
        {
            var catalog = new SupportedMediaCatalog();
            var supportedMediaTypes = catalog.GetMediaTypes();

            var mediaType = PromptForMediaType(supportedMediaTypes);
            var media = (Media)catalog.GetInstance(mediaType);

            var content = PromptForContent(media);

            media.Burn(content);
        }
    }
}
