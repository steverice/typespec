// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace _Type.Property.AdditionalProperties.Models
{
    public partial class SpreadModelArrayRecord : IJsonModel<SpreadModelArrayRecord>
    {
        void IJsonModel<SpreadModelArrayRecord>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        SpreadModelArrayRecord IJsonModel<SpreadModelArrayRecord>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual SpreadModelArrayRecord JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<SpreadModelArrayRecord>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        SpreadModelArrayRecord IPersistableModel<SpreadModelArrayRecord>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual SpreadModelArrayRecord PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<SpreadModelArrayRecord>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        public static implicit operator BinaryContent(SpreadModelArrayRecord spreadModelArrayRecord) => throw null;

        public static explicit operator SpreadModelArrayRecord(ClientResult result) => throw null;
    }
}