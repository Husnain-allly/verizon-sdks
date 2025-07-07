
# Address

The customer address for the line's primary place of use, for line usage taxation.

*This model accepts additional fields of type unknown.*

## Structure

`Address`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `addressLine1` | `string` | Required | The street address for the line's primary place of use. This must be a physical address for taxation; it cannot be a P.O. box. |
| `addressLine2` | `string \| undefined` | Optional | Optional additional street address information. |
| `city` | `string` | Required | The city for the line's primary place of use. |
| `state` | `string` | Required | The state for the line's primary place of use. |
| `zip` | `string` | Required | The ZIP code for the line's primary place of use. |
| `zip4` | `string \| undefined` | Optional | The ZIP+4 for the line's primary place of use. |
| `country` | `string` | Required | Either “US” or “USA” for the country of the line's primary place of use. |
| `phone` | `string \| undefined` | Optional | A phone number where the customer can be reached. |
| `phoneType` | `string \| undefined` | Optional | A single letter to indicate the customer phone type. |
| `emailAddress` | `string \| undefined` | Optional | An email address for the customer. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "addressLine1": "1600 Pennsylvania Ave NW",
  "city": "Washington",
  "state": "DC",
  "zip": "20500",
  "country": "USA",
  "addressLine2": "addressLine28",
  "zip4": "zip42",
  "phone": "phone8",
  "phoneType": "phoneType2",
  "emailAddress": "emailAddress8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

