
# Search Device Event History Request

Search Device By Property resource definition.

*This model accepts additional fields of type Object.*

## Structure

`SearchDeviceEventHistoryRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountidentifier` | [`AccountIdentifier`](../../doc/models/account-identifier.md) | Required | The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`. | AccountIdentifier getAccountidentifier() | setAccountidentifier(AccountIdentifier accountidentifier) |
| `MSelection` | `Map<String, String>` | Optional | A comma-separated list of properties and comparator values to match against subscriptions in the ThingSpace account. See Working with Query Filters for more information. If the request does not include `$selection`, the response will include all subscriptions to which the requesting user has access. | Map<String, String> getMSelection() | setMSelection(Map<String, String> mSelection) |
| `Resourceidentifier` | [`ResourceIdentifier`](../../doc/models/resource-identifier.md) | Required | The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}. | ResourceIdentifier getResourceidentifier() | setResourceidentifier(ResourceIdentifier resourceidentifier) |
| `MLimitnumber` | `Integer` | Optional | The maximum number of events to include in the response. | Integer getMLimitnumber() | setMLimitnumber(Integer mLimitnumber) |
| `MPage` | `String` | Optional | The maximum number of events to include in the response. | String getMPage() | setMPage(String mPage) |
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
  "$selection": {
    "addressscheme": "streamawsiot"
  },
  "resourceidentifier": {
    "id": "2e61a17d-8fd1-6816-e995-e4c2528bf535",
    "imei": "imei2",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "$limitnumber": 2,
  "$page": "$page6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

