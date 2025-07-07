
# Gpu

GPU resources of a service profile.

## Structure

`Gpu`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `minCoreClockMHz` | `?int` | Optional | Minimum Core Clock value in megahertz.<br><br>**Constraints**: `>= 1`, `<= 10000` | getMinCoreClockMHz(): ?int | setMinCoreClockMHz(?int minCoreClockMHz): void |
| `minMemoryClockMHz` | `?int` | Optional | Minimum Memory Clock value in megahertz.<br><br>**Constraints**: `>= 1`, `<= 100000` | getMinMemoryClockMHz(): ?int | setMinMemoryClockMHz(?int minMemoryClockMHz): void |
| `minBandwidthGBs` | `?int` | Optional | Minimum GPU bandwidth in GB/s.<br><br>**Constraints**: `>= 1`, `<= 1000` | getMinBandwidthGBs(): ?int | setMinBandwidthGBs(?int minBandwidthGBs): void |
| `minTflops` | `?int` | Optional | Minimum Floating Point Operations Per Second in Teraflops.<br><br>**Constraints**: `>= 1`, `<= 100` | getMinTflops(): ?int | setMinTflops(?int minTflops): void |

## Example (as JSON)

```json
{
  "minCoreClockMHz": 1,
  "minMemoryClockMHz": 35740,
  "minBandwidthGBs": 588,
  "minTFLOPS": 33
}
```

