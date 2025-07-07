
# Carrier Service Plan

*This model accepts additional fields of type array.*

## Structure

`CarrierServicePlan`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `name` | `?string` | Optional | The name of the service plan<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` | getName(): ?string | setName(?string name): void |
| `code` | `?string` | Optional | The inventory name or system name of the service plan<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` | getCode(): ?string | setCode(?string code): void |
| `sizeKb` | `?string` | Optional | The ammount of space the service plan will occupy on the Subscriber Information Module (SIM)<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` | getSizeKb(): ?string | setSizeKb(?string sizeKb): void |
| `carrierServicePlanCode` | `?string` | Optional | The billing record ID. This can be numeric, alpha or alphanumeric.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` | getCarrierServicePlanCode(): ?string | setCarrierServicePlanCode(?string carrierServicePlanCode): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "name": "name6",
  "code": "code4",
  "sizeKb": "sizeKb6",
  "carrierServicePlanCode": "carrierServicePlanCode4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

