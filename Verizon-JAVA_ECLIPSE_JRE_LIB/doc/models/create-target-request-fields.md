
# Create Target Request Fields

*This model accepts additional fields of type Object.*

## Structure

`CreateTargetRequestFields`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Httpheaders` | [`FieldsHttpHeaders`](../../doc/models/fields-http-headers.md) | Optional | - | FieldsHttpHeaders getHttpheaders() | setHttpheaders(FieldsHttpHeaders httpheaders) |
| `Devicetypes` | `List<String>` | Optional | List of device types. | List<String> getDevicetypes() | setDevicetypes(List<String> devicetypes) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "httpheaders": {
    "Authorization": "SharedAccessSignature sr=d1f9b6bf-1380-41f6-b757-d9805e48392b&sig=EF5tnXClw3MWkb84OkIOUhMH%2FaS1DRD2nXT69QR8RD8%3D&skn=TSCCtoken&se=1648827260410",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "devicetypes": [
    "cHeAssetTracker",
    "cHeAssetTrackerV2",
    "tgAssetTracker",
    "tgAssetTrackerV2"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

