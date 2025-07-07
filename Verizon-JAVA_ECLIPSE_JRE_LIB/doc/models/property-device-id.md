
# Property Device Id

## Structure

`PropertyDeviceId`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Optional | - | String getId() | setId(String id) |
| `Kind` | `String` | Optional | The type of the device identifier. Valid types of identifiers are:ESN (decimal),EID,ICCID (up to 20 digits),IMEI (up to 16 digits),MDN,MEID (hexadecimal),MSISDN. | String getKind() | setKind(String kind) |

## Example (as JSON)

```json
{
  "kind": "imei",
  "id": "id2"
}
```

