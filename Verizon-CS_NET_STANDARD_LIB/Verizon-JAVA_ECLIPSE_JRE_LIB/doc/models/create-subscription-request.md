
# Create Subscription Request

The details of the subscription that you want to create.

*This model accepts additional fields of type Object.*

## Structure

`CreateSubscriptionRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountidentifier` | [`AccountIdentifier`](../../doc/models/account-identifier.md) | Optional | The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`. | AccountIdentifier getAccountidentifier() | setAccountidentifier(AccountIdentifier accountidentifier) |
| `Description` | `String` | Optional | Descriptive information about the subscription. | String getDescription() | setDescription(String description) |
| `Disabled` | `Boolean` | Optional | Enable or disable the subscription. A disabled subscription will not send any data. | Boolean getDisabled() | setDisabled(Boolean disabled) |
| `Email` | `String` | Optional | The address to which any error reports should be delivered. | String getEmail() | setEmail(String email) |
| `Filter` | `String` | Optional | String containing a $filter object with a property and value to filter out non-matching events. | String getFilter() | setFilter(String filter) |
| `Billingaccountid` | `String` | Optional | - | String getBillingaccountid() | setBillingaccountid(String billingaccountid) |
| `Streamkind` | `String` | Optional | The type of event data to send via this subscription. This will be `ts.event` in most cases. Other event types are `ts.event.diagnostics` for device diagnostic data, `ts.event.configuration` for device configuration events, or `ts.event.security`. Note that the device ThingSpace client must support sending specific event types for anything other than `ts.event`. | String getStreamkind() | setStreamkind(String streamkind) |
| `Targetid` | `String` | Optional | The ID of the target resource to be used when dispatching events. The corresponding target should have a “stream” addressscheme. | String getTargetid() | setTargetid(String targetid) |
| `Name` | `String` | Optional | Name of the subscription. | String getName() | setName(String name) |
| `Allowaggregation` | `Boolean` | Optional | Setting this value to `false` prevents the data returned from being aggregated and makes the data easier to parse. | Boolean getAllowaggregation() | setAllowaggregation(Boolean allowaggregation) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountidentifier": {
    "billingaccountid": "0000000000-00001",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "billingaccountid": "0000000000-00001",
  "streamkind": "ts.event",
  "targetid": "your target ID UUID such as ae110c40-2685-6c70-f46e-286f7370b8a9",
  "name": "name your subscription",
  "description": "description8",
  "disabled": false,
  "email": "email4",
  "filter": "filter2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

