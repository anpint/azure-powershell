namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Extensions;

    public partial class SkuLocationInfo
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.ISkuLocationInfo.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.ISkuLocationInfo.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.ISkuLocationInfo FromJson(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonObject json ? new SkuLocationInfo(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonObject into a new instance of <see cref="SkuLocationInfo" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SkuLocationInfo(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_location = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonString>("location"), out var __jsonLocation) ? (string)__jsonLocation : (string)Location;}
            {_zone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonArray>("zones"), out var __jsonZones) ? If( __jsonZones as Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : Zone;}
            {_zoneDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonArray>("zoneDetails"), out var __jsonZoneDetails) ? If( __jsonZoneDetails as Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.ISkuZoneDetail[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.ISkuZoneDetail) (Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.SkuZoneDetail.FromJson(__p) )) ))() : null : ZoneDetail;}
            {_extendedLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonArray>("extendedLocations"), out var __jsonExtendedLocations) ? If( __jsonExtendedLocations as Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonString __j ? (string)(__j.ToString()) : null)) ))() : null : ExtendedLocation;}
            {_type = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SkuLocationInfo" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SkuLocationInfo" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._location)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonString(this._location.ToString()) : null, "location" ,container.Add );
            if (null != this._zone)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.XNodeArray();
                foreach( var __x in this._zone )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("zones",__w);
            }
            if (null != this._zoneDetail)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.XNodeArray();
                foreach( var __s in this._zoneDetail )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("zoneDetails",__r);
            }
            if (null != this._extendedLocation)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.XNodeArray();
                foreach( var __n in this._extendedLocation )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("extendedLocations",__m);
            }
            AddIf( null != (((object)this._type)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}