# PrivateApiNetworkRespondPanElementAddRequestRequest1

**Properties**

| Name       | Type                                | Required | Description                         |
| :--------- | :---------------------------------- | :------- | :---------------------------------- |
| Status     | RespondPanElementAddRequestStatus   | ✅       | The request's status.               |
| Response\_ | RespondPanElementAddRequestResponse | ❌       | The response to the user's request. |

# RespondPanElementAddRequestStatus

The request's status.

**Properties**

| Name     | Type   | Required | Description |
| :------- | :----- | :------- | :---------- |
| Denied   | string | ✅       | "denied"    |
| Approved | string | ✅       | "approved"  |

# RespondPanElementAddRequestResponse

The response to the user's request.

**Properties**

| Name    | Type   | Required | Description                                               |
| :------ | :----- | :------- | :-------------------------------------------------------- |
| Message | string | ❌       | A message that details why the user's request was denied. |

<!-- This file was generated by liblab | https://liblab.com/ -->
