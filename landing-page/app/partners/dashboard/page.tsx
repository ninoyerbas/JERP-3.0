'use client';

import { useEffect, useState } from 'react';
import { useSession } from 'next-auth/react';
import { DollarSign, Users, TrendingUp, Clock } from 'lucide-react';

interface DashboardStats {
  totalReferrals: number;
  activeCustomers: number;
  totalEarnings: number;
  pendingEarnings: number;
  tier: string;
  commissionRate: number;
  recentReferrals: any[];
}

export default function DashboardPage() {
  const { data: session } = useSession();
  const [stats, setStats] = useState<DashboardStats | null>(null);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    // Fetch dashboard stats (mocked for now)
    setTimeout(() => {
      setStats({
        totalReferrals: 12,
        activeCustomers: 8,
        totalEarnings: 2450.50,
        pendingEarnings: 327.25,
        tier: 'SILVER',
        commissionRate: 0.30,
        recentReferrals: [
          {
            id: '1',
            customerEmail: 'cliente@example.com',
            status: 'ACTIVE',
            plan: 'Pro',
            mrr: 109,
            createdAt: '2024-01-15',
          },
        ],
      });
      setLoading(false);
    }, 500);
  }, []);

  if (loading) {
    return (
      <div className="flex items-center justify-center h-64">
        <div className="text-white">Cargando...</div>
      </div>
    );
  }

  return (
    <div>
      <div className="mb-8">
        <h1 className="text-3xl font-bold text-white mb-2">
          Bienvenido, {session?.user?.name}
        </h1>
        <p className="text-slate-400">
          Aquí está tu resumen de rendimiento
        </p>
      </div>

      {/* Stats Grid */}
      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-6 mb-8">
        <div className="bg-slate-800/50 border border-slate-700 rounded-xl p-6">
          <div className="flex items-center justify-between mb-4">
            <Users className="w-8 h-8 text-blue-400" />
            <span className="text-2xl font-bold text-white">
              {stats?.totalReferrals || 0}
            </span>
          </div>
          <h3 className="text-slate-400 text-sm">Total Referidos</h3>
        </div>

        <div className="bg-slate-800/50 border border-slate-700 rounded-xl p-6">
          <div className="flex items-center justify-between mb-4">
            <TrendingUp className="w-8 h-8 text-green-400" />
            <span className="text-2xl font-bold text-white">
              {stats?.activeCustomers || 0}
            </span>
          </div>
          <h3 className="text-slate-400 text-sm">Clientes Activos</h3>
        </div>

        <div className="bg-slate-800/50 border border-slate-700 rounded-xl p-6">
          <div className="flex items-center justify-between mb-4">
            <DollarSign className="w-8 h-8 text-yellow-400" />
            <span className="text-2xl font-bold text-white">
              ${stats?.totalEarnings.toFixed(2) || '0.00'}
            </span>
          </div>
          <h3 className="text-slate-400 text-sm">Ganancias Totales</h3>
        </div>

        <div className="bg-slate-800/50 border border-slate-700 rounded-xl p-6">
          <div className="flex items-center justify-between mb-4">
            <Clock className="w-8 h-8 text-red-400" />
            <span className="text-2xl font-bold text-white">
              ${stats?.pendingEarnings.toFixed(2) || '0.00'}
            </span>
          </div>
          <h3 className="text-slate-400 text-sm">Pendiente de Pago</h3>
        </div>
      </div>

      {/* Tier Status */}
      <div className="bg-gradient-to-r from-slate-800 to-slate-700 border border-slate-600 rounded-xl p-6 mb-8">
        <div className="flex items-center justify-between">
          <div>
            <h3 className="text-lg font-semibold text-white mb-1">
              Nivel Actual: {stats?.tier === 'BRONZE' ? '🥉 Bronce' : stats?.tier === 'SILVER' ? '🥈 Plata' : '🥇 Oro'}
            </h3>
            <p className="text-slate-400">
              Tasa de comisión: {((stats?.commissionRate || 0) * 100).toFixed(0)}%
            </p>
          </div>
          <div className="text-right">
            <p className="text-sm text-slate-400 mb-1">Próximo nivel en</p>
            <p className="text-2xl font-bold text-white">
              {stats?.tier === 'BRONZE' ? 6 - (stats?.activeCustomers || 0) : 
               stats?.tier === 'SILVER' ? 16 - (stats?.activeCustomers || 0) : 
               '✅'} {stats?.tier !== 'GOLD' && 'clientes'}
            </p>
          </div>
        </div>
      </div>

      {/* Recent Referrals */}
      <div className="bg-slate-800/50 border border-slate-700 rounded-xl p-6">
        <h2 className="text-xl font-bold text-white mb-4">Referidos Recientes</h2>
        <div className="space-y-4">
          {stats?.recentReferrals && stats.recentReferrals.length > 0 ? (
            stats.recentReferrals.map((referral) => (
              <div key={referral.id} className="flex items-center justify-between p-4 bg-slate-900/50 rounded-lg">
                <div>
                  <p className="text-white font-medium">{referral.customerEmail}</p>
                  <p className="text-sm text-slate-400">
                    Plan {referral.plan} • ${referral.mrr}/mes
                  </p>
                </div>
                <div className="text-right">
                  <span className={`px-3 py-1 rounded-full text-xs font-medium ${
                    referral.status === 'ACTIVE' ? 'bg-green-500/20 text-green-400' :
                    referral.status === 'TRIAL' ? 'bg-yellow-500/20 text-yellow-400' :
                    'bg-slate-500/20 text-slate-400'
                  }`}>
                    {referral.status}
                  </span>
                  <p className="text-xs text-slate-400 mt-1">{referral.createdAt}</p>
                </div>
              </div>
            ))
          ) : (
            <p className="text-slate-400 text-center py-8">
              Aún no tienes referidos. ¡Comienza a compartir tu enlace!
            </p>
          )}
        </div>
      </div>
    </div>
  );
}
