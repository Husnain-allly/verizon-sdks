
# Customernamequery

## Structure

`Customernamequery`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `customerName` | [`?(CustomerName[])`](../../doc/models/customer-name.md) | Optional | **Constraints**: *Maximum Items*: `5` | getCustomerName(): ?array | setCustomerName(?array customerName): void |

## Example (as JSON)

```json
{
  "customerName": [
    {
      "title": "title4",
      "firstName": "firstName4",
      "middleName": "middleName8",
      "lastName": "lastName4",
      "suffix": "suffix0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "title": "title4",
      "firstName": "firstName4",
      "middleName": "middleName8",
      "lastName": "lastName4",
      "suffix": "suffix0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ]
}
```

