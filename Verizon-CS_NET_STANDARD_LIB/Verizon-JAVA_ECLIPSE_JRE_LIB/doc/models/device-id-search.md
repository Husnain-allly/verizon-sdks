
# Device Id Search

Search by device id.

*This model accepts additional fields of type Object.*

## Structure

`DeviceIdSearch`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Contains` | `String` | Required | The string appears anywhere in the identifer. | String getContains() | setContains(String contains) |
| `Startswith` | `String` | Optional | The identifer must start with the specified string. | String getStartswith() | setStartswith(String startswith) |
| `Endswith` | `String` | Optional | The identifier must end with the specified string. | String getEndswith() | setEndswith(String endswith) |
| `Kind` | `String` | Required | The type of the device identifier. Valid types of identifiers are:ESN (decimal),EID,ICCID (up to 20 digits),IMEI (up to 16 digits),MDN,MEID (hexadecimal),MSISDN. | String getKind() | setKind(String kind) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "kind": "iccid",
  "contains": "4259",
  "startswith": "startswith2",
  "endswith": "endswith4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

