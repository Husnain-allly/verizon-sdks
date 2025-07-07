
# Device Id Search

Search by device id.

*This model accepts additional fields of type array.*

## Structure

`DeviceIdSearch`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `contains` | `string` | Required | The string appears anywhere in the identifer. | getContains(): string | setContains(string contains): void |
| `startswith` | `?string` | Optional | The identifer must start with the specified string. | getStartswith(): ?string | setStartswith(?string startswith): void |
| `endswith` | `?string` | Optional | The identifier must end with the specified string. | getEndswith(): ?string | setEndswith(?string endswith): void |
| `kind` | `string` | Required | The type of the device identifier. Valid types of identifiers are:ESN (decimal),EID,ICCID (up to 20 digits),IMEI (up to 16 digits),MDN,MEID (hexadecimal),MSISDN. | getKind(): string | setKind(string kind): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

