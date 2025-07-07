
# Carrier Service Plan

*This model accepts additional fields of type unknown.*

## Structure

`CarrierServicePlan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `string \| undefined` | Optional | The name of the service plan<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `code` | `string \| undefined` | Optional | The inventory name or system name of the service plan<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `sizeKb` | `string \| undefined` | Optional | The ammount of space the service plan will occupy on the Subscriber Information Module (SIM)<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `carrierServicePlanCode` | `string \| undefined` | Optional | The billing record ID. This can be numeric, alpha or alphanumeric.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

