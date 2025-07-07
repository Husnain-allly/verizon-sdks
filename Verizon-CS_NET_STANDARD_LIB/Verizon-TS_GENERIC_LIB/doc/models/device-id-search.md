
# Device Id Search

Search by device id.

*This model accepts additional fields of type unknown.*

## Structure

`DeviceIdSearch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contains` | `string` | Required | The string appears anywhere in the identifer. |
| `startswith` | `string \| undefined` | Optional | The identifer must start with the specified string. |
| `endswith` | `string \| undefined` | Optional | The identifier must end with the specified string. |
| `kind` | `string` | Required | The type of the device identifier. Valid types of identifiers are:ESN (decimal),EID,ICCID (up to 20 digits),IMEI (up to 16 digits),MDN,MEID (hexadecimal),MSISDN. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

