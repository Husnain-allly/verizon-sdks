
# Provisioning History

The provisioning history of a specified device during a specified time period.

*This model accepts additional fields of type Object.*

## Structure

`ProvisioningHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `occurred_at` | `String` | Optional | The date and time when the provisioning event occured. |
| `status` | `String` | Optional | The success or failure of the provisioning event. |
| `event_by` | `String` | Optional | The user who performed the provisioning event. |
| `event_type` | `String` | Optional | The provisioning action:Activate,Suspend,Restore,Deactivate,Device Move. |
| `mdn` | `String` | Optional | The MDN assigned to the device after the provisioning event. |
| `msisdn` | `String` | Optional | The MSISDN assigned to the device after the provisioning event. |
| `service_plan` | `String` | Optional | The service plan of the device after the provisioning event occurred. |
| `extended_attributes` | [`Array<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Any extended attributes for the event, as Key and Value pairs. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

