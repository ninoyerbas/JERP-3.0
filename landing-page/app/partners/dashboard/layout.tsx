'use client';

import { useSession, signOut } from 'next-auth/react';
import Link from 'next/link';
import { usePathname } from 'next/navigation';
import { 
  LayoutDashboard, 
  Users, 
  DollarSign, 
  Link as LinkIcon, 
  FolderOpen, 
  GraduationCap, 
  Settings, 
  LogOut 
} from 'lucide-react';

const navigation = [
  { name: 'Dashboard', href: '/partners/dashboard', icon: LayoutDashboard },
  { name: 'Referidos', href: '/partners/dashboard/referrals', icon: Users },
  { name: 'Comisiones', href: '/partners/dashboard/commissions', icon: DollarSign },
  { name: 'Links', href: '/partners/dashboard/links', icon: LinkIcon },
  { name: 'Recursos', href: '/partners/dashboard/resources', icon: FolderOpen },
  { name: 'Academia', href: '/partners/dashboard/academy', icon: GraduationCap },
  { name: 'Configuración', href: '/partners/dashboard/settings', icon: Settings },
];

export default function DashboardLayout({
  children,
}: {
  children: React.ReactNode;
}) {
  const { data: session } = useSession();
  const pathname = usePathname();

  return (
    <div className="min-h-screen bg-gradient-to-br from-slate-900 via-slate-800 to-slate-900">
      <div className="flex">
        {/* Sidebar */}
        <aside className="w-64 min-h-screen bg-slate-900/50 border-r border-slate-700 flex flex-col">
          <div className="p-6 border-b border-slate-700">
            <h1 className="text-xl font-bold text-white">JERP Partners</h1>
            {session?.user && (
              <p className="text-sm text-slate-400 mt-2">{session.user.email}</p>
            )}
          </div>

          <nav className="flex-1 p-4">
            {navigation.map((item) => {
              const isActive = pathname === item.href;
              return (
                <Link
                  key={item.href}
                  href={item.href}
                  className={`flex items-center gap-3 px-4 py-3 rounded-lg mb-2 transition-all ${
                    isActive
                      ? 'bg-red-500 text-white'
                      : 'text-slate-400 hover:bg-slate-800 hover:text-white'
                  }`}
                >
                  <item.icon className="w-5 h-5" />
                  <span>{item.name}</span>
                </Link>
              );
            })}
          </nav>

          <div className="p-4 border-t border-slate-700">
            <button
              onClick={() => signOut({ callbackUrl: '/partners/login' })}
              className="flex items-center gap-3 px-4 py-3 rounded-lg text-slate-400 hover:bg-slate-800 hover:text-white transition-all w-full"
            >
              <LogOut className="w-5 h-5" />
              <span>Cerrar Sesión</span>
            </button>
          </div>
        </aside>

        {/* Main Content */}
        <main className="flex-1 p-8">
          {children}
        </main>
      </div>
    </div>
  );
}
