
# Dto List Smart Alerts Request

## Structure

`DtoListSmartAlertsRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountname` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountname(): ?string | setAccountname(?string accountname): void |
| `filter` | [`?DtoFilter`](../../doc/models/dto-filter.md) | Optional | - | getFilter(): ?DtoFilter | setFilter(?DtoFilter filter): void |
| `resourceidentifier` | [`?DtoResourceidentifier`](../../doc/models/dto-resourceidentifier.md) | Optional | - | getResourceidentifier(): ?DtoResourceidentifier | setResourceidentifier(?DtoResourceidentifier resourceidentifier): void |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "filter": {
    "$expand": "$expand0",
    "$limitnumber": 100,
    "$nopagination": false,
    "$page": "$page0",
    "$pagenumber": 64
  },
  "resourceidentifier": {
    "id": "id4"
  }
}
```

