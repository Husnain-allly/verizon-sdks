
# Account Leads Result

Returns information for all leads associated with an account.

*This model accepts additional fields of type Object.*

## Structure

`AccountLeadsResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `HasMoreData` | `Boolean` | Optional | False if no more leads.True if there is more data to be retrieved. | Boolean getHasMoreData() | setHasMoreData(Boolean hasMoreData) |
| `Leads` | [`List<AccountLead>`](../../doc/models/account-lead.md) | Optional | The leads associated with an account. | List<AccountLead> getLeads() | setLeads(List<AccountLead> leads) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "leads": [
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
  ],
  "hasMoreData": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

