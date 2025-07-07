
# Carrier Information

Information about the carrier.

*This model accepts additional fields of type Object.*

## Structure

`CarrierInformation`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `CarrierName` | `String` | Optional | The carrier that will perform the activation. This parameter is only required if you have more than one carrier. | String getCarrierName() | setCarrierName(String carrierName) |
| `ServicePlan` | `String` | Optional | The service plan code that is assigned to the device. | String getServicePlan() | setServicePlan(String servicePlan) |
| `State` | `String` | Optional | The device state. Valid values include: Activate, Suspend, Deactive, Pre-active. | String getState() | setState(String state) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "carrierName": "Verizon Wireless",
  "servicePlan": "m2m4G",
  "state": "active",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

