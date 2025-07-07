
# List Service Profiles Result

Response on successful retrieval of service profiles.

## Structure

`ListServiceProfilesResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Status` | `String` | Optional | HTTP status code.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getStatus() | setStatus(String status) |
| `Data` | `List<String>` | Optional | A comma delimited list of all the service profiles registered under your API key.<br><br>**Constraints**: *Maximum Items*: `100`, *Maximum Length*: `32` | List<String> getData() | setData(List<String> data) |

## Example (as JSON)

```json
{
  "status": "Success",
  "data": [
    "data3",
    "data4",
    "data5"
  ]
}
```

