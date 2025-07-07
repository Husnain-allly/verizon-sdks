
# Account Lead

A successful response returns an array of lead objects.

*This model accepts additional fields of type interface{}.*

## Structure

`AccountLead`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Address` | [`*models.Address`](../../doc/models/address.md) | Optional | The customer address for the line's primary place of use, for line usage taxation. |
| `LeadId` | `*string` | Optional | Unique number for each lead. Use this value in the leadId parameter when activating devices to credit the activations to the lead. |
| `LeadState` | `*string` | Optional | The current state of the lead, such as “Qualified” or “Closed.” |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "leadId": "L-10001",
  "leadState": "Qualified",
  "address": {
    "addressLine1": "1600 Pennsylvania Avenue",
    "addressLine2": "",
    "city": "Washington",
    "state": "DC",
    "zip": "20500",
    "country": "USA",
    "zip4": "zip40",
    "phone": "phone4",
    "phoneType": "phoneType0",
    "emailAddress": "emailAddress6",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

