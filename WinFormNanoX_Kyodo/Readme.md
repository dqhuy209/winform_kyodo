### Overview TODO (đồng bộ với Sapporo)

- [ ] Thêm Input cấu hình (HinoTools.Solar)
  - **inputCO2Rate1 (InputCO2Rate)**
    - **TagCO2Rate**: `ITNCommonSolar.CO2Constant` (NodePath trong NanoX)
    - **TagResult**: `ITNCommonSolar.CO2ReductionOverview`
  - **inputMoneyConstant1 (InputMoneyConstant)**
    - **TagResult**: `ITNCommonReport.MoneySave`
  - Yêu cầu: thêm `HinoTools.Solar.dll` vào Kyodo và kéo/thả 2 control vào Designer

- [ ] Hiển thị icon Generator theo trạng thái GEN/GRID như Sapporo
  - Cần 2 Node/Tag trạng thái:
    - **GEN status**: `StatusGENACB.ON`
    - **GRID status**: `StatusMAINACB.ON`
  - Logic timer: nếu GEN == 1 và GRID == 0 → Show `picGen`/`labelGenerator`, ngược lại Hide
  - Thêm 2 `NanoXLabel` ẩn bind Node hoặc đọc giá trị qua connector để cập nhật mỗi tick

- [ ] Xác nhận NodePath cho các giá trị đang hiển thị (NanoXLabel)
  - `nanoXLabel_ValueSolar` → ví dụ: `ITNCommonSolar.ActivePower`
  - `nanoXLabel_ValueGenerator` → ví dụ: `ITNCommonGrid.ActivePower`
  - `nanoXLabel_ValueIrradiance` → `WSWeatherStation.Irradiance`
  - `nanoXLabel_ValueIER` → chỉ hiển thị (không bind Node)
  - `ValueLoad` (Label WinForms) → tính từ Solar + Grid

---

Gợi ý triển khai nhanh khi sẵn sàng:

1) Thêm reference `HinoTools.Solar.dll`, kéo `InputCO2Rate` và `InputMoneyConstant` vào `frmOverview`.
2) Gán Tag/Proc/DB theo bảng trên và cấu hình `TimerName = timer1` nếu control hỗ trợ.
3) Tạo 2 `NanoXLabel` ẩn để bind `StatusGENACB.ON` và `StatusMAINACB.ON`, cập nhật `timer1_Tick` theo điều kiện.