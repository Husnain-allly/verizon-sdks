
# HttpConfiguration

The following parameters are configurable for the HttpConfiguration:

## Properties

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| timeout | `float64` | Timeout in milliseconds.<br>*Default*: `30` | `WithTimeout` | `Timeout()` |
| transport | `http.RoundTripper` | Establishes network connection and caches them for reuse.<br>*Default*: `http.DefaultTransport` | `WithTransport` | `Transport()` |
| retryConfiguration | [`verizon.RetryConfiguration`](../doc/retry-configuration.md) | Configurations to retry requests.<br>*Default*: `verizon.DefaultRetryConfiguration()` | `WithRetryConfiguration` | `RetryConfiguration()` |

The httpConfiguration can be initialized as follows:

```go
httpConfiguration := verizon.CreateHttpConfiguration(
    verizon.WithTimeout(30),
    verizon.WithTransport(http.DefaultTransport),
    verizon.WithRetryConfiguration(verizon.DefaultRetryConfiguration()),
)
```

