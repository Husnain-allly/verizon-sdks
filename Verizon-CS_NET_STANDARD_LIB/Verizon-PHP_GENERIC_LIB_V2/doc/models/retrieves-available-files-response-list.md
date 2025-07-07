
# Retrieves Available Files Response List

*This model accepts additional fields of type array.*

## Structure

`RetrievesAvailableFilesResponseList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `availableFilesResponse` | [`?(RetrievesAvailableFilesResponse[])`](../../doc/models/retrieves-available-files-response.md) | Optional | **Constraints**: *Maximum Items*: `100` | getAvailableFilesResponse(): ?array | setAvailableFilesResponse(?array availableFilesResponse): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

