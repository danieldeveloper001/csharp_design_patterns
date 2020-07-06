using System;
using System.Collections.Generic;

namespace Project
{
    class SupportedMediaCatalog
    {
        private Dictionary<MediaType, Media> _catalog;

        public SupportedMediaCatalog()
        {
            _catalog = new Dictionary<MediaType, Media>();
            _catalog.Add(MediaType.CD, new Media(
                700.0m,
                MediaCapacityUnit.MB,
                MediaType.CD));

            _catalog.Add(MediaType.DVD, new Media(
                4.7m,
                MediaCapacityUnit.GB,
                MediaType.DVD));

            _catalog.Add(MediaType.BD, new Media(
                25.0m,
                MediaCapacityUnit.GB,
                MediaType.BD));
        }

        public IEnumerable<MediaType> GetMediaTypes() =>
            _catalog.Keys;

        public IMedia GetInstance(MediaType type) =>
            (IMedia)_catalog[type].Clone();


    }
}