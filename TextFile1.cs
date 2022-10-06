
// 螺栓
private void showBoltModel(Color color)
{
    // 第一次调用是在update  选择螺栓数据中new的Bolt(boltChooseClass)
    if (boltChooseClass == null)
    {
        throw new Exception("bolt is null");
    }
    simulation1.Entities.Clear();
    simulation1.Enabled = true;
    try
    {
        _boltEntity = _bolt.GetEntity();
        simulation1.Entities.Add(_boltEntity, color);
        simulation1.ZoomFit();
        simulation1.Invalidate();

		// 清空连接件
        dataClampedChoosed.Rows.Clear();
        clampedList.Clear();
        // 螺母垫片会自动更新

    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw new Exception("输入参数错误！请仔细检查");
    }
}