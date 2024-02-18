namespace OutlandArea.Interfaces.Universe.IndustrialPlants;

public interface IPlant
{
    long Id { get; set; }
    long WarehouseId { get; set; }
    List<IRawMaterial> Input { get; set; }
    List<IRawMaterial> Output { get; set; }
    bool IsWarehouseHaveInputRawMaterials();
    bool IsWarehouseHaveCapacityForOutputRawMaterials();
    void ExecutePlantWorkCycle();
}
