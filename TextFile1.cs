
// ��˨
private void showBoltModel(Color color)
{
    // ��һ�ε�������update  ѡ����˨������new��Bolt(boltChooseClass)
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

		// ������Ӽ�
        dataClampedChoosed.Rows.Clear();
        clampedList.Clear();
        // ��ĸ��Ƭ���Զ�����

    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw new Exception("���������������ϸ���");
    }
}