// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace _Type.Property.ValueTypes.Models
{
    public partial class CollectionsStringProperty : IJsonModel<CollectionsStringProperty>
    {
        void IJsonModel<CollectionsStringProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        CollectionsStringProperty IJsonModel<CollectionsStringProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual CollectionsStringProperty JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<CollectionsStringProperty>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        CollectionsStringProperty IPersistableModel<CollectionsStringProperty>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual CollectionsStringProperty PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<CollectionsStringProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        public static implicit operator BinaryContent(CollectionsStringProperty collectionsStringProperty) => throw null;

        public static explicit operator CollectionsStringProperty(ClientResult result) => throw null;
    }
}