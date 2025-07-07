
# Provisioning History

The provisioning history of a specified device during a specified time period.

*This model accepts additional fields of type Object.*

## Structure

`ProvisioningHistory`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `OccurredAt` | `String` | Optional | The date and time when the provisioning event occured. | String getOccurredAt() | setOccurredAt(String occurredAt) |
| `Status` | `String` | Optional | The success or failure of the provisioning event. | String getStatus() | setStatus(String status) |
| `EventBy` | `String` | Optional | The user who performed the provisioning event. | String getEventBy() | setEventBy(String eventBy) |
| `EventType` | `String` | Optional | The provisioning action:Activate,Suspend,Restore,Deactivate,Device Move. | String getEventType() | setEventType(String eventType) |
| `Mdn` | `String` | Optional | The MDN assigned to the device after the provisioning event. | String getMdn() | setMdn(String mdn) |
| `Msisdn` | `String` | Optional | The MSISDN assigned to the device after the provisioning event. | String getMsisdn() | setMsisdn(String msisdn) |
| `ServicePlan` | `String` | Optional | The service plan of the device after the provisioning event occurred. | String getServicePlan() | setServicePlan(String servicePlan) |
| `ExtendedAttributes` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Any extended attributes for the event, as Key and Value pairs. | List<CustomFields> getExtendedAttributes() | setExtendedAttributes(List<CustomFields> extendedAttributes) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "occurredAt": "2015-12-17T13:56:13-05:00",
  "status": "Success",
  "eventBy": "Harry Potter",
  "eventType": "Activation Confirmed",
  "servicePlan": "Tablet5GB",
  "mdn": "",
  "msisdn": "15086303371",
  "extendedAttributes": [],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

