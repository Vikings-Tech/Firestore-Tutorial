using Firebase.Firestore;

[FirestoreData]
public struct Counter
{
    [FirestoreProperty]
    public int Count { get; set; }

    [FirestoreProperty]
    public string UpdatedBy { get; set; }
}
