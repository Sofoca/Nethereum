﻿namespace Nethereum.RPC
{
    public enum ApiMethods
    {
        net_listening,
        eth_protocolVersion,
        eth_syncing,
        eth_coinbase,
        eth_mining,
        eth_hashrate,
        eth_gasPrice,
        eth_accounts,
        eth_blockNumber,
        eth_getBalance,
        eth_getStorageAt,
        eth_getTransactionCount,
        eth_getBlockTransactionCountByHash,
        eth_getBlockTransactionCountByNumber,
        eth_getUncleCountByBlockHash,
        eth_getUncleCountByBlockNumber,
        eth_getCode,
        eth_sign,
        eth_sendTransaction,
        eth_sendRawTransaction,
        eth_call,
        eth_estimateGas,
        eth_getBlockByHash,
        eth_getBlockByNumber,
        eth_getTransactionByHash,
        eth_getTransactionByBlockHashAndIndex,
        eth_getTransactionByBlockNumberAndIndex,
        eth_getTransactionReceipt,
        eth_getUncleByBlockHashAndIndex,
        eth_getUncleByBlockNumberAndIndex,
        eth_getCompilers,
        eth_compileLLL,
        eth_compileSolidity,
        eth_compileSerpent,
        eth_newFilter,
        eth_newBlockFilter,
        eth_newPendingTransactionFilter,
        eth_uninstallFilter,
        eth_getFilterChanges,
        eth_getFilterLogs,
        eth_getLogs,
        eth_getWork,
        eth_submitWork,
        eth_submitHashrate,
        shh_post,
        shh_version,
        shh_newIdentity,
        shh_hasIdentity,
        shh_newGroup,
        shh_addToGroup,
        shh_newFilter,
        shh_uninstallFilter,
        shh_getFilterChanges,
        shh_getMessages,
        web3_clientVersion,
        web3_sha3,
        net_version,
        net_peerCount
        ,
        personal_listAccounts,
        personal_newAccount,
        personal_unlockAccount,
        admin_addPeer,
        admin_nodeInfo,
        admin_datadir,
        admin_startRPC,
        admin_setSolc,
        admin_startWS,
        admin_stopRPC,
        admin_stopWS,
        debug_blockProfile,
        debug_backtraceAt,
        debug_dumpBlock,
        debug_cpuProfile,
        debug_gcStats,
        debug_getBlockRlp,
        debug_goTrace,
        debug_memStats,
        debug_seedHash,
        debug_setBlockProfileRate,
        debug_stacks,
        debug_startCPUProfile,
        debug_startGoTrace,
        debug_stopCPUProfile,
        debug_stopGoTrace,
        debug_traceBlock,
        debug_traceBlockByNumber,
        debug_traceBlockByHash,
        debug_traceBlockFromFile,
        debug_traceTransaction,
        debug_verbosity,
        debug_vmodule,
        miner_hashrate,
        miner_start,
        miner_stop,
        miner_setGasPrice,
        personal_lockAccount,
        personal_sendTransaction
    }
}