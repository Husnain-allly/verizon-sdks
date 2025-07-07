
# Dto List Network Experience History Request

## Structure

`DtoListNetworkExperienceHistoryRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountname` | `String` | Optional | The numeric account name, which must include leading zeros | String getAccountname() | setAccountname(String accountname) |
| `Filter` | [`DtoFilter`](../../doc/models/dto-filter.md) | Optional | - | DtoFilter getFilter() | setFilter(DtoFilter filter) |

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

