
# Gpu

GPU resources of a service profile.

## Structure

`Gpu`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `minCoreClockMHz` | `number \| undefined` | Optional | Minimum Core Clock value in megahertz.<br><br>**Constraints**: `>= 1`, `<= 10000` |
| `minMemoryClockMHz` | `number \| undefined` | Optional | Minimum Memory Clock value in megahertz.<br><br>**Constraints**: `>= 1`, `<= 100000` |
| `minBandwidthGBs` | `number \| undefined` | Optional | Minimum GPU bandwidth in GB/s.<br><br>**Constraints**: `>= 1`, `<= 1000` |
| `minTflops` | `number \| undefined` | Optional | Minimum Floating Point Operations Per Second in Teraflops.<br><br>**Constraints**: `>= 1`, `<= 100` |

## Example (as JSON)

```json
{
  "minCoreClockMHz": 1,
  "minMemoryClockMHz": 35740,
  "minBandwidthGBs": 588,
  "minTFLOPS": 33
}
```

