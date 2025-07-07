
# Carrier Service Plan

*This model accepts additional fields of type Any.*

## Structure

`CarrierServicePlan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `str` | Optional | The name of the service plan<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `code` | `str` | Optional | The inventory name or system name of the service plan<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `size_kb` | `str` | Optional | The ammount of space the service plan will occupy on the Subscriber Information Module (SIM)<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `carrier_service_plan_code` | `str` | Optional | The billing record ID. This can be numeric, alpha or alphanumeric.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

