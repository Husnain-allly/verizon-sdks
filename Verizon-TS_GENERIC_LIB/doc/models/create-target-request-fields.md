
# Create Target Request Fields

*This model accepts additional fields of type unknown.*

## Structure

`CreateTargetRequestFields`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `httpheaders` | [`FieldsHttpHeaders \| undefined`](../../doc/models/fields-http-headers.md) | Optional | - |
| `devicetypes` | `string[] \| undefined` | Optional | List of device types. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

