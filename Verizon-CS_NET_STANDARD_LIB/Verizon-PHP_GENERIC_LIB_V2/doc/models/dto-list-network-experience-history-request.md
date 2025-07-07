
# Dto List Network Experience History Request

## Structure

`DtoListNetworkExperienceHistoryRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountname` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountname(): ?string | setAccountname(?string accountname): void |
| `filter` | [`?DtoFilter`](../../doc/models/dto-filter.md) | Optional | - | getFilter(): ?DtoFilter | setFilter(?DtoFilter filter): void |

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
  }
}
```

