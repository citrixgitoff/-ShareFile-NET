﻿using System.Runtime.CompilerServices;

#if ShareFile
#if SIGNED
[assembly: InternalsVisibleTo("ShareFile.Api.Client.Core.Internal, PublicKey=0024000004800000940000000602000000240000525341310004000001000100072814e41fdbe3ae14cca4cad075417f8154bacb64a4a8a830b5f9e453e7f119a8b9e0e7a47a9a4847f0ad88bf61056e03f17bd5c6e8a59eb9ccc20f2c21afae54a60d0a83f16b39d6907c3f7739a1166bc259a6852ffd5831dc8503a2b5c808096c8059e0092ae8b3cf4c0ca4e9ebb98385949ee83cc3fc10900c05db2210c8")]
#else
[assembly: InternalsVisibleTo("ShareFile.Api.Client.Core.Internal")]
#endif
#endif
