
# Retrieves Available Files Response List

*This model accepts additional fields of type object.*

## Structure

`RetrievesAvailableFilesResponseList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AvailableFilesResponse` | [`List<RetrievesAvailableFilesResponse>`](../../doc/models/retrieves-available-files-response.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

