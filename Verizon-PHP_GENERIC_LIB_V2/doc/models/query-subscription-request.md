
# Query Subscription Request

Fields and values to match.

*This model accepts additional fields of type array.*

## Structure

`QuerySubscriptionRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountidentifier` | [`?AccountIdentifier`](../../doc/models/account-identifier.md) | Optional | The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`. | getAccountidentifier(): ?AccountIdentifier | setAccountidentifier(?AccountIdentifier accountidentifier): void |
| `mSelection` | `?array<string,string>` | Optional | A comma-separated list of properties and comparator values to match against subscriptions in the ThingSpace account. See Working with Query Filters for more information. If the request does not include `$selection`, the response will include all subscriptions to which the requesting user has access. | getMSelection(): ?array | setMSelection(?array mSelection): void |
| `resourceidentifier` | [`?ResourceIdentifier`](../../doc/models/resource-identifier.md) | Optional | The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}. | getResourceidentifier(): ?ResourceIdentifier | setResourceidentifier(?ResourceIdentifier resourceidentifier): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountidentifier": {
    "billingaccountid": "1223334444-00001",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "resourceidentifier": {
    "id": "dd1682d3-2d80-cefc-f3ee-25154800beff",
    "imei": "imei2",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "$selection": {
    "key0": "$selection9",
    "key1": "$selection0",
    "key2": "$selection1"
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

