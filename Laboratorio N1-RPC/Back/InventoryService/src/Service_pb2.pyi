from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from typing import ClassVar as _ClassVar, Optional as _Optional

DESCRIPTOR: _descriptor.FileDescriptor

class ChangeProduct(_message.Message):
    __slots__ = ["item", "num"]
    ITEM_FIELD_NUMBER: _ClassVar[int]
    NUM_FIELD_NUMBER: _ClassVar[int]
    item: str
    num: int
    def __init__(self, item: _Optional[str] = ..., num: _Optional[int] = ...) -> None: ...

class CheckProduct(_message.Message):
    __slots__ = ["item"]
    ITEM_FIELD_NUMBER: _ClassVar[int]
    item: str
    def __init__(self, item: _Optional[str] = ...) -> None: ...

class TransactionResponse(_message.Message):
    __slots__ = ["inventory", "status"]
    INVENTORY_FIELD_NUMBER: _ClassVar[int]
    STATUS_FIELD_NUMBER: _ClassVar[int]
    inventory: int
    status: bool
    def __init__(self, status: bool = ..., inventory: _Optional[int] = ...) -> None: ...
