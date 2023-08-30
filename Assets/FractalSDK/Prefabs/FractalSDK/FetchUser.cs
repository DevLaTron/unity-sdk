using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FractalSDK;
using FractalSDK.Models.Api;
using FractalSDK.Core;

public class FetchUser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async void fetchData()
    {
        try
        {
            TransactionUrl urltoSign = await FractalClient.Instance.SignTransaction("XGbYe8A2uT4oUB5s64hDQE8A7mqW3NTex9U5ugCTvGpnoYh8xgdyJStbuhhLYACHbsMyqVXRvQQ8hXyHsH2paP3vGLJp1RnfMnyv4BrFDx2h9hveJgGfi7u5Gy8TE8iD66bjucdxv3BTxmKyJknUq9cZyM4iKYmVMCmTyqi31mJvr1zcYuSouaAmNR5nGSifeV7pkJDuNQrVWv4wTmLkYHinT3Qq1R3RWxv4zVrSojn5eFktuLY8qaNq9bnHa4PrWzB2A9Qf9rKgErrrM3genmcuK9qRY9M99g4kGphADvaTfzmeZDxx8vY8X57TGahMAHrDn1P7yRmHF2mRtWmqAwhjadqhVaSwM5ZzuweR3Tt8guE7mvFyzLmURvpQfNCGTi65YjqEmubPDP9z2Ks4utPUKxcmQVSN4T8Qm9i4cc6qPRiVqDggPKMHX9M4hhg5Mnirxxg5kUAf8r9fjLVNyYei3TijAHmEYu8nFi1m65oHJR8v4HrF2dXJn8mvYRpLLGsGpEec8ZGrWS2RwNVahV8c1XeNAyxYSCXD6uHRLXz4ujjG3AN93wqPRfY9yvW3fV72oprJwbiUjPWvDqb3hXADPPvK5ZbDxnYqysQArwhkBZMzEPAM1SHTCtmbWaZ4b1v3DnvDGcZ6BUqHjR47Bt8GCbpygdcfCBNnThrAGMPHJUHQ15qWNQjXqbSNDbFZAfiRv4rbegotm79eh3mArM3rhQfWFaqee1TBRKTGR3PoPhFMUoyrsA4WYtBnVadtwkhzTZtP9Y9Dw7pCwHohQqMuw5R41FgwKmAcJhfyVVqCNYgFJnudUXKK9T5iepyTCPeaJcWKwZMitauwtYtBv4t8yqvh93py1SN6RWTSmZcJT3DurPmtbyb1Seh6QebZxrc7NAvGhQYeZvqXBN2yHTCdRDHehfp8mDmK3e43h3VxB9DXw58GGYw9X8LhzhMJoHDVtiNRJRGyyF7tc8CbrBtsFEGRmWw1nFDn1wQsSkY833fcoBj2CJA9LexDBuKwpi2pSrMnEEiUDmjsuGU3yDW8Bm4pufeyHc4crhM4HHFYG1u8XghGH7zf9gLkkXHcVnqq1KWs4DtbzEuKY1Mr3vFJhYXY6v8Lu8gdiB9fb3aKoxC1yJrbP8nfDtgHNGkSRQJsszTu4hGm9uX2sK2MKMRS51NjtN1hEG5K5yDBVLjrqHUKBZRyEKAjGMfFRzJPCUR5RDgsimyJUqB3gra3xejF5Ny3csaoh9y8G2JdA4CkrZPBvpDFQqyBMUG5AUH7KkF5syiVTJ9nqkLsMa3xdmw4Ph");
            Debug.Log(urltoSign);
        }
        catch (FractalAPIRequestError e)
        {
            Debug.LogError(e.Message);
        }

       
    }

}
