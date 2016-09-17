using System.Linq;

using HoloToolkit.Unity;

using UnityEngine;

public class GenerateObjects : MonoBehaviour
{
    #region member vars

    private BoundedPlane[] planes;

    public GameObject TV;

    #endregion

    #region methods

    private void OnDrawGizmos()
    {
        if (planes != null)
        {
            for (int i = 0; i < planes.Length; ++i)
            {
                Vector3 center = planes[i].Bounds.Center;
                Quaternion rotation = planes[i].Bounds.Rotation;
                Vector3 extents = planes[i].Bounds.Extents;
                Vector3 normal = planes[i].Plane.normal;
                center -= planes[i].Plane.GetDistanceToPoint(center) * normal;

                Vector3[] corners = new Vector3[4]
                {
                    center + rotation * new Vector3(+extents.x, +extents.y, 0), center + rotation * new Vector3(-extents.x, +extents.y, 0), center + rotation * new Vector3(-extents.x, -extents.y, 0),
                    center + rotation * new Vector3(+extents.x, -extents.y, 0)
                };

                Color color = Color.magenta;

                Gizmos.color = color;
                Gizmos.DrawLine(corners[0], corners[1]);
                Gizmos.DrawLine(corners[0], corners[2]);
                Gizmos.DrawLine(corners[0], corners[3]);
                Gizmos.DrawLine(corners[1], corners[2]);
                Gizmos.DrawLine(corners[1], corners[3]);
                Gizmos.DrawLine(corners[2], corners[3]);
                Gizmos.DrawLine(center, center + normal * 0.4f);
            }
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    public void PlaceContent()
    {
        var meshes = SpatialMappingManager.Instance.GetMeshFilters().Select(m => new PlaneFinding.MeshData(m)).ToList();
        planes = PlaneFinding.FindSubPlanes(meshes);

        foreach (var plane in planes)
        {
            var tmp = (GameObject)Instantiate(GameObject.CreatePrimitive(PrimitiveType.Plane), plane.Bounds.Center, plane.Bounds.Rotation);
            tmp.transform.localScale = plane.Bounds.Extents;
        }

        foreach (var plane in FlatPlanes)
        {
            Debug.Log(plane.Bounds.Center);
            // Instantiate(TV, plane.Bounds.Center, Quaternion.identity);
        }
    }

    #endregion

    #region properties

    public BoundedPlane[] FlatPlanes
    {
        get
        {
            return planes.Where(
                plane =>
                {
                    plane.Plane.normal.Normalize();
                    return plane.Plane.normal.y > 0.9;
                }).ToArray();
        }
    }

    #endregion
}