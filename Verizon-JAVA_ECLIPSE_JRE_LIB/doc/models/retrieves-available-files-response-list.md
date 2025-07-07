
# Retrieves Available Files Response List

*This model accepts additional fields of type Object.*

## Structure

`RetrievesAvailableFilesResponseList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AvailableFilesResponse` | [`List<RetrievesAvailableFilesResponse>`](../../doc/models/retrieves-available-files-response.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<RetrievesAvailableFilesResponse> getAvailableFilesResponse() | setAvailableFilesResponse(List<RetrievesAvailableFilesResponse> availableFilesResponse) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "AvailableFilesResponse": [
    {
      "fileName": "fileName2",
      "fileVersion": "fileVersion4",
      "releaseNote": "releaseNote0",
      "make": "make2",
      "model": "model6",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

